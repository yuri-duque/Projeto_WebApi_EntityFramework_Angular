import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgxSmartModalModule } from 'ngx-smart-modal';
import { FormsModule } from '@angular/forms';
import {NgxMaskModule} from 'ngx-mask';

import { AlunosDetalhesComponent } from './alunos-detalhes/alunos-detalhes.component';
import { AlunosFormComponent } from './alunos-form/alunos-form.component';
import { AlunosRouting } from './alunos-routing.module';
import { AlunosComponent } from './alunos.component';

@NgModule({
  declarations: [
    AlunosComponent,
    AlunosDetalhesComponent, 
    AlunosFormComponent
  ],
  imports: [
    CommonModule,
    AlunosRouting,
    NgxSmartModalModule.forChild(),
    NgxMaskModule.forRoot(),
    FormsModule
  ]
})
export class AlunosModule { }
