import { Component, OnInit } from '@angular/core';
import { AuthorizeGuard } from '../../api-authorization/authorize.guard';
import { RecipeService } from '../services/recipe.service'; 

@Component({
  selector: 'app-recipe-add',
  templateUrl: './recipe-add.component.html',
  styleUrls: ['./recipe-add.component.css']
})
export class RecipeAddComponent implements OnInit {

  constructor(private authorizeGuard: AuthorizeGuard, private recipeService: RecipeService) { }

  recipe: any = {
    name: '',
    description: '',
    title: '',
    IsApproved: '', 
    Difficulty: '',
    Category: '',
    Duration: ''
  };

  ngOnInit(): void { }

  onSubmit() {
    // Chame o serviço para adicionar a receita
    this.recipeService.addRecipe(this.recipe).subscribe(
      (response) => {
        console.log('Receita adicionada com sucesso:', response);
        // Faça redirecionamento ou ações adicionais se necessário
      },
      (error) => {
        console.error('Erro ao adicionar receita:', error);
      }
    );
  }
}
