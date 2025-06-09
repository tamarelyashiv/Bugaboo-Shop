import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { product } from '../Classes/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
all:Array<product>=new Array<product>()
  constructor(public server:HttpClient) {}
  basicUrl:string="https://localhost:7156/api/Bugaboo"
   selectAllAsync():Observable<Array<product>>{
    return this.server.get<Array<product>> (`${this.basicUrl}`)
   }
// סנון לפי השרת
  getByCategoryAndModel(idc: number, idm: number): Observable<product[]> {
    return this.server.get<product[]>(`https://localhost:7096/api/productControllers/byModel?categoryId=${idc}&modelId=${idm}`);
  }
}
