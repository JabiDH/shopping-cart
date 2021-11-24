import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { Product } from '../../models/product';
import { ProductService } from '../../services/product/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  
  products: Product[] = [];

  constructor(private productService: ProductService) { }

  ngOnInit(){
    this.productService.getProducts().subscribe( (products) =>
      this.products.push(...products)
    );
  }

  share() {
    window.alert('The product has been shared!');
  }

  onNotify() {
    window.alert('You will be notified when product goes on sale.');
  }
}


/*
Copyright Google LLC. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at https://angular.io/license
*/