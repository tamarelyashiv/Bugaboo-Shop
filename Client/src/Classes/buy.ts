import { CartService } from "../Services/cart.service";
import { product } from "./Product";

export class buy {
    constructor(
        public customerId?: number,
        public dateBirth?:Date,
        public cartItems?: { [key: string]: { product: product; quantity: number } }, // עדכון כאן
        public remark?: string,
        public buyDate?: Date,
        public payment?:number
    ) {}
}