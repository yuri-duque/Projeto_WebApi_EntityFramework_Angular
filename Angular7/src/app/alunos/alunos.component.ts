import { Component, OnInit } from '@angular/core';
import { NgxSmartModalService } from 'ngx-smart-modal';
import { AlunosService } from './alunos.service';
import { Aluno } from '../models/Aluno';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  alunos: Aluno[] = [];
  colunas: any[] = ["Id", "Nome", "CPF", "Idade"];

  constructor(
    public ngxSmartModalService: NgxSmartModalService,
    private alunosService: AlunosService
    ) {
  }

  ngOnInit() {  
    this.alunosService.list()
      .subscribe(dados => this.alunos = dados);
  }

  Open(id: number) {
    //alert(id);
    this.ngxSmartModalService.getModal('myModal').open();
  }
}
