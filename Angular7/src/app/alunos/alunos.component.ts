import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  constructor() {}

  ngOnInit() {  
  }

  colunas: any[] = ["Nome", "CPF", "Idade"];

  alunos: Alunos[] = [
    {Id: 1, Nome: 'Yuri', CPF: '000.000.000-01', Idade: 22},
    {Id: 2, Nome: 'Laryssa', CPF: '000.000.000-02', Idade: 20}
  ]
}

export class Alunos{
  Id: number;
  Nome: string;
  CPF: String;
  Idade: number;
}
