import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AlunosDetalhesComponent } from './alunos-detalhes/alunos-detalhes.component';
import { AlunosFormComponent } from './alunos-form/alunos-form.component';
import { AlunosRouting } from './alunos-routing.module';

@NgModule({
  declarations: [
    AlunosDetalhesComponent, 
    AlunosFormComponent
  ],
  imports: [
    CommonModule,
    AlunosRouting
  ]
})
export class AlunosModule { }
