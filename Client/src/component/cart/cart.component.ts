import { CommonModule, CurrencyPipe } from '@angular/common';
import { Component } from '@angular/core';
import { CartService } from '../../Services/cart.service';
import { CustomerService } from '../../Services/customer.service';
import { FormsModule } from '@angular/forms';
import { DirectiveDirective } from '../../directive/directive.directive';
import { ButtunComponent } from '../buttun/buttun.component';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cart',
  standalone: true,
  imports: [CurrencyPipe,CommonModule,FormsModule,DirectiveDirective,ButtunComponent],
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.css'
})
export class CartComponent {
  products: any[] = [];
  constructor(private cs: CartService,private sc:CustomerService,private router: Router) { }
  ngOnInit() {
    const cartItems = this.getCart(); // קבלת המוצרים בסל
    this.products = Object.values(cartItems); // המרת האובייקט למערך
    this.loadCart()
  }
 quntity: number = 1;
//יש אפשרות לקנות רק אם הלקוח מחובר
  pay(){
    if(this.sc.cust==null)
      alert('עליך להתחבר לחשבון')
    else
    alert( "שלום"+this.sc.cust.nameCustomer)
  }
//הוספת הקניה
add() {
  //מה שחוזר מהעגלת קניות
  const cartItems = this.getCart(); 
  //בדיקה אם העגלה מלאה
  if (!cartItems || Object.keys(cartItems).length === 0) {
      console.error('העגלת קניות ריקה או לא מוגדרת');
      return;
  }
//נשלח ל servies עם הערה מהhtml
  this.cs.add(cartItems, this.remark).subscribe(response => {
    //אם הקריאת שרת הצליחה
      if (response) {
          this.cs.addBuyDeatails(cartItems).subscribe(
              success => {
                  if (success) {
                      alert('ההזמנה בוצעה בהצלחה הפרטים עודכנו!');
                  } else {
                      alert('הייתה שגיאה בהוספת פרטי הקנייה.');
                  }
              },
              error => {
                  console.error('Error adding buy details:', error);
              }
          );
      } else {
          alert('הייתה שגיאה בביצוע ההזמנה.');
      }
  }, error => {
      console.error('Error adding item:', error);
  });
  alert("העסקה בוצעה בהצלחה תודה ולהתראות👍🏽")
  this.router.navigate([``]);
}

sumPay(){
  this.sum()
}
//מחיקה
delete(product: any) {
  // מחק את המוצר מהעגלת קניות
  if (this.cs.cartItems[product.product.productId]) {
    delete this.cs.cartItems[product.product.productId]; // הסרת המוצר מהעגלת קניות
    sessionStorage.setItem('cartItems', JSON.stringify(this.cs.cartItems)); // עדכון הsession
  }
  
  // עדכון המערך של המוצרים
  this.products = this.products.filter(p => p.product.productId !== product.product.productId);
}
//כמות המוצרים לרכישה - או פלוס
count(qunt: boolean, product: any) {
  console.log('Count function called with:', qunt, product);
  if (qunt){
    //עדכון של עגלת הקניות את הquantity
    this.cs.cartItems[product.product.productId].quantity+=1
    //תצוגה
    product.quantity+=1
    //sessionשמירה ב
    sessionStorage.setItem('cartItems', JSON.stringify(this.cs.cartItems));
  } else {
    //בדיקה שלא יהיה מאופשר להוריד כמות של מוצר פחות מ-0
    if (product.quantity > 0) {
      this.cs.cartItems[product.product.productId].quantity-=1
      product.quantity-=1
      //שמירה בsession
      sessionStorage.setItem('cartItems', JSON.stringify(this.cs.cartItems));
    }
  }
  if (this.cs.cartItems[product.product.id]) {
    console.log('Current cartItems:', this.cs.cartItems);
    this.cs.cartItems[product.product.id].quantity = product.quantity;
    console.log(`Updated cartItems for ${product.product.nameProduct}:`, this.cs.cartItems);
    sessionStorage.setItem('cartItems', JSON.stringify(this.cs.cartItems));
  }
}
 public remark=""
//קבלת העגלה
  getCart() {
    const items = sessionStorage.getItem('cartItems');
    this.cs.cartItems = items ? JSON.parse(items) : {}; // קריאה מ-Session Storage
    return this.cs.cartItems;
  }
  //טעינת העגלה וטעינה בonInit
  loadCart() {
    const items = sessionStorage.getItem('cartItems');
    this.cs.cartItems = items ? JSON.parse(items) : {}; 
}
//הסכום לתשלום
sum() {
  // קבלת פריטי העגלה
  const cartItems1 = this.getCart(); 
  console.log("cartItems1:", cartItems1);
  let total = 0;
  //הcartItems1 מכיל את העגלה שמכילה פרטי מוצר וכמות 
  //בודקת שהאובייקט לא ריק
  if (typeof cartItems1 === 'object' && cartItems1 !== null) {
    //עובר על העגלת קניות ועל כל פריט בודק את הכמות ואז עושה את החישוב
      Object.values(cartItems1).forEach(item => {
          if (item.product && item.product.price !== undefined && item.quantity !== undefined) { 
            //המשתנה total ואז זה מכפיל את הכמות של המוצר כפול המחיר
              total += item.product.price * item.quantity;
             
          } else {
              console.warn("product, price או quantity אינם מוגדרים עבור item:", item);
          }
      });
  } else {
      console.error("cartItems1 אינו אובייקט תקין");
  }
  return total; // מחזיר את הסכום
}
//pop up כאשר רוצים לעבור לתשלום
//code pen
openDialog() {
  const dialog = document.getElementById('dialogOne') as HTMLDialogElement;
  if (dialog) {
    // הצגת הדיאלוג
    dialog.style.display = 'flex'; 
    dialog.showModal();
  }
}

closeDialog() {
  const dialog = document.getElementById('dialogOne') as HTMLDialogElement;
  if (dialog) {
    dialog.close();
    dialog.style.display = 'none'; // הסתרת הדיאלוג
  }
}
}

