import { Component, Directive, OnInit } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { ProductService } from '../../../Services/product.service';
import { product } from '../../../Classes/Product';
import { CurrencyPipe } from '@angular/common';
import { Router } from '@angular/router'; // תקן את הייבוא כאן
import { Location } from '@angular/common';
import { CartService } from '../../../Services/cart.service';
import { ButtunComponent } from '../../buttun/buttun.component';
@Component({
  selector: 'app-details',
  standalone: true,
  imports: [CurrencyPipe,ButtunComponent],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})

export class DetailsComponent implements OnInit {
  constructor(public pc:ProductService ,public cs:CartService,public ar:ActivatedRoute,private route: ActivatedRoute,public location:Location,private router:Router){
   //מערך לכל המוצרים
    this.allP = [];
  }
  product:any;
  allP: Array<product> = new Array<product>()

    ngOnInit() {
      this.route.params.subscribe(params => {
        const idString = params['pId'];
        if (idString) {
          const id = +idString; 
          // קריאה לשרת כדי לטעון את המוצרים
          this.pc.selectAllAsync().subscribe(products => {
            this.allP = products;
            this.getProductDetails(id); // חפש את המוצר לפי ה-ID
          }, error => {
            console.error('Error fetching products:', error);
          });
        } else {
          console.error('ID is null or undefined');
        }
      });
    }
    //חיפוש המוצר לפי הקוד
    getProductDetails(id: number) {
      this.product = this.allP.find(product => product.productId === id); 
    }
    addToCart() {
      console.log(this.product);
      this.cs.addToCart(this.product); // הוספת המוצר לסל
  }
 back(){
    this.location.back()//חוזר לדף המוצר
  }

}
