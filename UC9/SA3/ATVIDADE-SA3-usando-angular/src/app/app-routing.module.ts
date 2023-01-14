import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContatoComponent } from './views/contato/contato.component';
import { HomeComponent } from './views/home/home.component';
import { LoginComponent } from './views/login/login.component';
import { ProdutosComponent } from './views/produtos/produtos.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "contato", component: ContatoComponent },
  { path: "login", component: LoginComponent },
  { path: "produtos", component: ProdutosComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
