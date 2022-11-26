import { Component, OnInit} from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { RecipeBookService } from 'src/app/recipe-book.service';
import { Recipe } from '../recipe.model';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
  recipe: Recipe;
  id: number;

  constructor(private service: RecipeBookService,private route: ActivatedRoute) { };

  ngOnInit(){
    this.route.params.subscribe((params: Params) => {
      this.id = this.route.snapshot.params['id'];
      this.service.getRecipe(this.id).subscribe((response:Recipe) => {
      this.recipe = response;});
    });
  }
};
