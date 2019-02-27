import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';
const routes: Routes = [
  {path: 'alunos', loadChildren:'./components/alunos/alunos.module#AlunosModule'}
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);
