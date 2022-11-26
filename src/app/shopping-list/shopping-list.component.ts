import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Ingredient } from '../shared/ingredient.model';
import { Observable } from 'rxjs';
import { RecipeBookService } from '../recipe-book.service';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit{

  ingredients:Observable<any[]>;

  constructor(private service: RecipeBookService) { }

  ngOnInit(){
    this.ingredients = this.service.getIngredients();
  }

}
