import { Component, OnInit } from '@angular/core';
import { NgxSmartModalService } from 'ngx-smart-modal';
import { AlunosService } from './alunos.service';
import { Aluno } from '../models/Aluno';
import { error } from 'util';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  alunos: Aluno[];
  //Usado para definir os nomes das colunas da tabela de listagem
  colunas: any[] = ["Id", "Nome", "CPF", "Idade"];

  constructor(
    public ngxSmartModalService: NgxSmartModalService,
    private alunosService: AlunosService
    ) {
  }

  ngOnInit() {  
    this.Listagem();
  }

  //Metodo usado para abir o modal de detalhes
  Open(id: number) {
    //alert(id);
    this.ngxSmartModalService.getModal('myModal').open();
  }

  //Listagem de alunos buscando na api
  Listagem(){
    //subscribe - Executa q query em async
    this.alunosService.list().subscribe(
      alunos => this.alunos = alunos
    ),
    //Caso de algum erro será tratado aqui
    error(

    ),
    //Metodo Complete - caso seja necessário buscar os alunos de uma sala especifica ( buca-se a sala na listame, depois realiza a busca dos alunos dentro do metodo abaixo)
    () => {
      
    }
  }
}
