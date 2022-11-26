import {HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject } from "rxjs";
import { Recipe } from './recipes/recipe.model';

@Injectable({
  providedIn: 'root'
})

export class RecipeBookService {

  readonly RecipeBookApiUrl = "https://localhost:44345/api";

  constructor(private http:HttpClient) {}

  //Ingredient

  getIngredients():Observable<any[]> {
    return this.http.get<any>(this.RecipeBookApiUrl + '/Ingredient');
  }

  addIngredient(data:any){
    return this.http.post(this.RecipeBookApiUrl + '/Ingredient', data);
  }

  updateIngredient(id:number|string, data:any){
    return this.http.put(this.RecipeBookApiUrl + `/Ingredient/${id}`, data);
  }

  deleteIngredient(id:number|string) {
    return this.http.delete(this.RecipeBookApiUrl + `/Ingredient/${id}`);
  }

  // Recipe

  getRecipe(id: number): Observable<Recipe> {
    return this.http.get<Recipe>(this.RecipeBookApiUrl + `/Recipe/${id}`);
  }

  getRecipes():Observable<any[]> {
    return this.http.get<any>(this.RecipeBookApiUrl + '/Recipe');
  }

  addRecipe(data:any){
    return this.http.post(this.RecipeBookApiUrl + '/Recipe', data);
  }

  updateRecipe(id:number|string, data:any){
    return this.http.put(this.RecipeBookApiUrl + `/Recipe/${id}`, data);
  }

  deleteRecipe(id:number|string) {
    return this.http.delete(this.RecipeBookApiUrl + `/Recipe/${id}`);
  }
}