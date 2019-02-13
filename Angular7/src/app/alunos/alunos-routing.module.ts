import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

import { AlunosComponent } from './alunos.component';
import { AlunosFormComponent } from './alunos-form/alunos-form.component';
import { AlunosDetalhesComponent } from './alunos-detalhes/alunos-detalhes.component';


const routes: Routes = [
  {path: 'alunos', component: AlunosComponent},
  {path: 'alunos/cadastro', component: AlunosFormComponent},
  {path: 'aluno/:id', component: AlunosFormComponent},
  {path: 'aluno/detalhes/', component: AlunosDetalhesComponent}
];

export const AlunosRouting: ModuleWithProviders = RouterModule.forChild(routes);
