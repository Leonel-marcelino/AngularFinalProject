import { Component, OnInit } from '@angular/core';
import { AuthorizeGuard } from '../../api-authorization/authorize.guard';

@Component({
  selector: 'app-recipe-add',
  templateUrl: './recipe-add.component.html',
  styleUrls: ['./recipe-add.component.css']
})
export class RecipeAddComponent implements OnInit {

  constructor(private authorizeGuard: AuthorizeGuard) { }

  ngOnInit(): void { }

}
