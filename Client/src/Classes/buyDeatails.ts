import { product } from "./Product";

export class buyDeatails {
    constructor(
        public buyId?:number,
        public productId?: number,
        public amount?:number,
        public cartItems?: { [key: string]: { product: product; quantity: number } }, // עדכון כאן
        
       
     
    ) {}
}