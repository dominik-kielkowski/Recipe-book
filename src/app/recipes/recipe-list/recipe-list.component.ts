import { Component, OnInit } from '@angular/core';
import { RecipeBookService } from 'src/app/recipe-book.service';
import { Recipe } from '../recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit{

  recipes: Recipe[];

  constructor(private service: RecipeBookService) { 
  }

  ngOnInit(): void {

    this.service.getRecipes().subscribe((recipes: Recipe[]) => {
      this.recipes = recipes;
    });
  }
}
