import { Component, Directive, OnInit } from '@angular/core';
import { ProductService } from '../../Services/product.service';
import { product } from '../../Classes/Product';
import {FormsModule} from '@angular/forms'
import { Router, RouterLink, RouterOutlet } from '@angular/router';
import { CommonModule, CurrencyPipe, NgClass } from '@angular/common';
import { ButtunComponent } from '../buttun/buttun.component';
import { DirectiveDirective } from '../../directive/directive.directive';
@Component({
  selector: 'app-product',
  standalone: true,
  imports: [NgClass, RouterOutlet,RouterLink,CurrencyPipe,FormsModule,CommonModule,ButtunComponent,DirectiveDirective],
  templateUrl:'./product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent implements OnInit {
  constructor(public pc:ProductService,private route:Router){
  }
  ngOnInit(): void {
    this.getProduct()
  }
  allP: Array<product> = new Array<product>()
  categories: string[] = []; 
  models: string[] = []; 

  getProduct() {
    this.pc.selectAllAsync().subscribe(
      d => {
        console.log(d);
        console.log("good");
        console.log(d[0].nameProduct);
        console.log(this.allP);
        this.allP = d
       },
      err => { console.log("error " + err.message) }
    )
    console.log("סוף הפונקציה");
  }
  //קבלת המוצרים
  get() {
    this.pc.selectAllAsync().subscribe(
      d => {
        console.log(d);
        this.allP = d;
        this.products = d;

        // הוצאת קטגוריות ייחודיות
        this.categories = Array.from(new Set(d.map(product => product.nameCategory).filter((name): name is string => name !== undefined)));

        // הוצאת מודלים ייחודיים
        this.models = Array.from(new Set(d.map(product => product.nameModel).filter((model): model is string => model !== undefined))); // שמות המודלים בלבד
      },
      err => { console.log("error " + err.message); }
    );
}
//פונקציה לדף הפרטים עם הקוד שנשלח בURL
  details(id?:number){
    if(id){
      this.route.navigate([`./product/details/${id}`])
   }
  }
  //מיונים בלקוח
  tosortprice(){
    this.allP.sort((a:product, b:product)=>{
    return a.price!-b.price!;
  })
}
tosortalef() {
  this.allP.sort((a: product, b: product) => {
    return a.nameProduct!.localeCompare(b.nameProduct!, 'en');
  });
}
categoryId: number = 0;
modelId: number = 0;
product: product | undefined;

products: product[] = []; 
// //סינון מהשרת
// search() {
//   this.products = []; 

//   if (this.categoryId > 0 && this.modelId > 0) {
//     this.products = this.allP.filter(product =>
//       product.nameCategory === String(this.categoryId) &&
//       product.nameModel === String(this.modelId)
//     );
//   } else {
//     console.log("אנא בחר קטגוריה ומודל תקפים");
//   }
// }


}
