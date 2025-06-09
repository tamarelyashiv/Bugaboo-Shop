import { Routes } from '@angular/router';
import { HomePageComponent } from '../component/HomePage/home-page/home-page.component';
import { ProductComponent } from '../component/product/product.component';
import { DetailsComponent } from '../component/details/details/details.component';
import { CustomerComponent } from '../component/customer/customer/customer.component';
import { CartComponent } from '../component/cart/cart.component';

    export const routes: Routes = [
        // המערך מקבל אובייקטים
        // בכל אובייקט לפחות 2 הגדרות:
        //path - מה יהיה כתוב בניתוב
        //component - מה להציג
        { path: 'home page', component: HomePageComponent },
        { path: 'customer', component: CustomerComponent },
        { path: 'product', component: ProductComponent, title: 'החנות'},
            // children - מערך ילדים
            //רכיבים המולבשים על רכיב זה
            //המערך הוא מאותו סוג אובייקטים
            //וכדי לגשת לניתוב זה יש צורך לכתוב את הניתוב של האבא ואחר כך של הבן
            // כל המוצרים/detailes/5
            // שליחת פרמטר בניתוב, נקדים נקודתיים למשתנה
        { path: 'product/details/:pId', component: DetailsComponent, title: 'shop' },
        { path: 'product/cart', component: CartComponent },
        // ניתוב ריק - הרכיב יוצג מיד בהתחלה
        { path: '', component: HomePageComponent },
        // ** - בכל מקרה שלא נמצא רכיב מתאים הצג רכיב זה
        { path: '**', component: DetailsComponent }
    ];


