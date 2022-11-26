import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RecipeBookService } from 'src/app/recipe-book.service';

@Component({
  selector: 'app-recipe-edit',
  templateUrl: './recipe-edit.component.html',
  styleUrls: ['./recipe-edit.component.css']
})
export class RecipeEditComponent implements OnInit {
  id: number;
  editMode = false;
  recipeForm: FormGroup;

  constructor(private service: RecipeBookService){ }

  ngOnInit() {}
}
