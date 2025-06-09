import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
// import { ProductComponent } from '../component/product/product.component';
import { CustomerComponent } from '../component/customer/customer/customer.component';
import { ProductComponent } from '../component/product/product.component';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  //יבאנו את הלינק
  imports: [RouterOutlet,ProductComponent,RouterLink,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Project';
}
