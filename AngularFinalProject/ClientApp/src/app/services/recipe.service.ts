/* eslint-disable @typescript-eslint/no-explicit-any */
// recipe.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RecipeService {
  private apiUrl = '/api/recipe'; // Substitua pela URL correta

  constructor(private http: HttpClient) { }

  addRecipe(recipe: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}`, recipe);
  }
}
