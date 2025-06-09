import { Injectable } from '@angular/core';
import { product } from '../Classes/Product';
import { catchError, Observable, throwError } from 'rxjs';
import { customer } from '../Classes/customer';
import { CustomerService } from './customer.service';
import { HttpClient } from '@angular/common/http';
import { ProductService } from './product.service';
import { buy } from '../Classes/buy';
import { buyDeatails } from '../Classes/buyDeatails';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})

export class CartService{
  public customer1: any;
  public birth1: any;
  constructor(private router: Router,public http:HttpClient,private cs:CustomerService,private pc:ProductService ){
    this.birth1=this.customer1?.dateBirth;
  }
  //dictinory הכמות מכל מוצר מכיל את פרטי המוצר ואת
  public cartItems: { [key: string]: { product: product, quantity: number } } = {};
//הוספת עגלה:
//בחרנו לעשות בservies כי השתמשנו בה גם בקומפוננטה של הdeatails
  addToCart(product1: product) {
    // קבלת אובייקט הלקוח
    const customer = this.cs.cust;
    // אם המשתמש מחובר
    if(customer){
    //מכניס לעגלה פרטי מוצר וכמות
    if (product1 && product1.productId) {
        if (this.cartItems[product1.productId]) {
            this.cartItems[product1.productId].quantity++;
        } else {
            this.cartItems[product1.productId] = { product: product1, quantity: 1 };
        }
        sessionStorage.setItem('cartItems', JSON.stringify(this.cartItems));
    } else {
        console.error('Product ID is missing or product1 is undefined');
    }
    this.router.navigate([`./product/cart`]);

  }
    else{
      alert("עליך להתחבר לחשבונך")
      this.router.navigate(['./customer']);
    }
  }
//הוספת הקניה עם קריאת שרת שנשלח לה אובייקט-body
add(cartItems:any, remark:string): Observable<boolean> {
  this.customer1 = this.cs.cust;
  const customer = this.cs.cust;
 
  if (!customer) {
    console.error("Customer is undefined");
    return throwError("Customer is undefined");
  }
  const birth1 = customer.dateBirth;
  console.log("Customer ID:", customer.customerId);
  if (customer.customerId === 0) {
    console.warn("Customer ID is 0, check the customer service.");
  }
  const body: buy = {
      dateBirth: birth1,
      cartItems: cartItems,
      remark: remark,
      buyDate: new Date(),
  };
 
  console.log('Request Body:', body);
 
  return this.http.post<boolean>('https://localhost:7156/api/Buy', body).pipe(
      catchError(error => {
          console.error('Error occurred:', error);
          return throwError(error);
      })
  );
}
//קריאת שרת והוספת הקניה
addBuyDeatails(cartItems:any): Observable<boolean> {
  console.log(cartItems);
  const body: buyDeatails = {
      cartItems: cartItems,
  };
  console.log('Request Body:', body);
  return this.http.post<boolean>('https://localhost:7156/api/BuyDeatails', body).pipe(
      catchError(error => {
          console.error('Error occurred:', error);
          return throwError(error);
      })
  );
}


}
