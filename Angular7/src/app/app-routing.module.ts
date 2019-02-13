import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
import { AppComponent } from './app.component';

const routes: Routes = [
  {path: 'alunos', loadChildren:'./alunos/alunos.module#AlunosModule'}
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);
