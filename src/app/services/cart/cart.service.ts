import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Product } from '../../products';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  ShippingApiEndpoint = environment.shippingCartEndPoint;

  constructor(private httpClient: HttpClient) { }

  items: Product[] = [];

  addToCart(product: Product) {
    this.items.push(product);
  }

  getItems() {
    return this.items;
  }

  clearCart() {
    this.items = [];
    return this.items;
  }

  getShippingPrices() {
    return this.httpClient.get<{ type: string, price: number}[]>(`${this.ShippingApiEndpoint}/api/shippingprices`);
  }

}
