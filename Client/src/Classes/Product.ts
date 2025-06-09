import {category  } from "./category";
import {model} from "./models"

export class product{
    constructor(public productId?:number, public nameProduct?:string,
        public categoryId:category=new category(),public modelId:model=new model(),public nameCategory?:string, public nameModel?:string,
     public descriptions?:string ,public price?:number,public picture?:string,public quantity?:number,public lastUpdate?:Date
    ){}
}
