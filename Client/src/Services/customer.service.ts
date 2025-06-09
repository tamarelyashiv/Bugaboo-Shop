

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, Observable, throwError, timeout } from 'rxjs';
import { customer } from '../Classes/customer';
@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  cust:customer | null = null;
 constructor(public server: HttpClient,) {}
 //שליחות שרת
  basicUrl: string = "https://localhost:7156/api/Cust";
  addCustomer(newCustomer: customer): Observable<customer> {
    return this.server.post<customer>(`${this.basicUrl}`, newCustomer);
  }
loginCustomer(email: string): Observable<customer> {
  return this.server.get<customer>(`https://localhost:7156/api/Cust?email=${email}`).pipe(
    map(c => this.cust= c),
    catchError(error => {
      console.error('Error occurred:', error);
      return throwError(error);
    })
  );
}
checkEmail(email: string): Observable<boolean> {
  const body = { email };
  console.log('Sending request with body:', body);
  return this.server.post<{ EmailExists: boolean }>(
    `https://localhost:7156/api/Cust/check-email?email=${encodeURIComponent(email)}`, 
    body,
    {
    }
  )
    .pipe(
      map(response => response.EmailExists),
      catchError(error => {
        console.error('Error occurred:', error);
        return throwError(error);
      })
    );
}
}

