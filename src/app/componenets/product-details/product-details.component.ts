import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../../models/product';
import { CartService } from '../../services/cart/cart.service';
import { ProductService } from '../../services/product/product.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {

  product: Product | undefined;

  constructor(
      private route: ActivatedRoute,
      private cartService: CartService,
      private productService: ProductService
    ) { }

  ngOnInit(): void {
    const params = this.route.snapshot.paramMap;
    const productId = Number(params.get('productId'));

    this.productService.getProduct(productId)
    .subscribe( product => this.product = product);
  }

  addToCart(product: Product){
    this.cartService.addToCart(product);
    window.alert(product.name + ' has been added to your cart!');
  }

}
