
import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../../../Services/customer.service';
import { customer } from '../../../Classes/customer';
import { FormsModule } from '@angular/forms';
import { CommonModule, NgClass } from '@angular/common';
import { Router } from '@angular/router';
import { CartService } from '../../../Services/cart.service';

@Component({
  selector: 'app-customer',
  standalone: true,
  imports: [FormsModule, NgClass,CommonModule],
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  constructor(public pc: CustomerService,public router:Router,private cs:CartService) {}
  ngOnInit(): void {
  }
  allP: Array<customer> = new Array<customer>();
 newCustomer: customer = new customer(); // ודא שהאובייקט מאותחל כראוי
loginOrRegiste:boolean=true
//המשתמש בוחר אם הוא רוצה להתחבר או להרשם
loginOrRegister(b:boolean)
{
 this.loginOrRegiste=b;         
}
emailExists: boolean = false;
// רשום עם בדיקה אם המייל קיים זה לא נרשם ויש להרשם עם מייל אחר
send() {
  if (this.newCustomer.email) {
    this.pc.checkEmail(this.newCustomer.email).subscribe(
      emailExists => {
        if (emailExists) {
          alert("האימייל קיים במערכת.");
        } else {
          this.pc.addCustomer(this.newCustomer).subscribe(
            response => {
              console.log("Customer saved successfully", response);
              this.router.navigate([`./product`]);
              alert("ברוכים הבאים, נרשמת בהצלחה!!");
            },
            err => { console.log("Error saving customer", err);
              alert("מייל קיים במערכת")
             }
          );
        }
      },
      err => { console.log("Error checking email", err); }
    );
  } else {
    alert("אנא הכנס אימייל.");
  }
}
//מקבל את המייל שהכניס
checkEmail1(email: string): void {
  this.pc.checkEmail(email).subscribe(exists => {
    this.emailExists = exists;
  });}
email:string=''
//התחברות אם אין כזה לקוח יש להרשם
  sendLogin(email: string) {
    this.pc.loginCustomer(this.email).subscribe(
        response => {
          if(response){
            console.log("Customer retrieved successfully", response);
            this.checkEmail(email);
            this.saveEmail(this.email);
            this.router.navigate([`./product`]);}
            else{
               alert("עליך להרשם!");
              }

        },
        err => { console.log("Error retrieving customer", err);
          alert("עליך להרשם!");
        }
    );
}
 // שמירה ב-sessionStorage 
saveEmail(email: string) {
  sessionStorage.setItem('emailCustomer', email);
}
//אם מתחבר לקוח אחר העגלה צריכה להתאפס
checkEmail(email: string) {
  const storedEmail = sessionStorage.getItem('emailCustomer');
  
  if (email !== storedEmail) {
    this.clearAllSessionData(); 
  } 
}
//מאפס את העגלה אם הלקוח אחר
clearAllSessionData() {
  // מוחק את העגלה מה-sessionStorage
  sessionStorage.removeItem('cartItems'); 
  //לוקח את העגלה מהשרת
  this.cs.cartItems = {}; 
  sessionStorage.clear();
}


}