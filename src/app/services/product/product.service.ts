import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Product } from '../../models/product';


@Injectable({
  providedIn: 'root'
})
export class ProductService {

  apiUrl = environment.shippingCartEndPoint;

  constructor(private httpClient: HttpClient) { }

  getProducts() {
    return this.httpClient.get<Product[]>(`${this.apiUrl}/api/products`);
  }

  getProduct(id: number) {
    return this.httpClient.get<Product>(`${this.apiUrl}/api/products/${id}`);
  }
}
