import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

import { AlunosComponent } from './alunos.component';
import { AlunosFormComponent } from './alunos-form/alunos-form.component';
import { AlunosDetalhesComponent } from './alunos-detalhes/alunos-detalhes.component';


const AlunoRoutes: Routes = [

  { path: '', redirectTo: '/alunos', pathMatch: 'full' },

  {path: '', component: AlunosComponent},
  {path: 'cadastro', component: AlunosFormComponent},
  {path: 'alterar/:id', component: AlunosFormComponent},
  {path: 'detalhes/:id', component: AlunosDetalhesComponent}
];

export const AlunosRouting: ModuleWithProviders = RouterModule.forChild(AlunoRoutes);
