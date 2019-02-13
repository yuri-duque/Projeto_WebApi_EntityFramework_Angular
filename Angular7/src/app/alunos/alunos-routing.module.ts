import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

import { AlunosComponent } from './alunos.component';
import { AlunosFormComponent } from './alunos-form/alunos-form.component';
import { AlunosDetalhesComponent } from './alunos-detalhes/alunos-detalhes.component';


const AlunoRoutes: Routes = [
  {path: '', component: AlunosComponent},
  {path: 'cadastro', component: AlunosFormComponent},
  {path: ':id', component: AlunosFormComponent},
  {path: 'detalhes/', component: AlunosDetalhesComponent}
];

export const AlunosRouting: ModuleWithProviders = RouterModule.forChild(AlunoRoutes);
