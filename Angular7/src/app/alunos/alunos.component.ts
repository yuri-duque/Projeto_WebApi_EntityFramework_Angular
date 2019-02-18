import { Component, OnInit } from '@angular/core';
import { NgxSmartModalService } from 'ngx-smart-modal';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  constructor(public ngxSmartModalService: NgxSmartModalService) {}

  ngOnInit() {  
  }

  colunas: any[] = ["Id", "Nome", "CPF", "Idade"];

  alunos: Alunos[] = [
    {id: 1, nome: 'Yuri', cpf: '000.000.000-01', idade: 22},
    {id: 2, nome: 'Laryssa', cpf: '000.000.000-02', idade: 20}
  ]

  Open(id: number) {
    //alert(id);
    this.ngxSmartModalService.getModal('myModal').open();
  }
}

export class Alunos{
  id: number;
  nome: string;
  cpf: String;
  idade: number;
}
