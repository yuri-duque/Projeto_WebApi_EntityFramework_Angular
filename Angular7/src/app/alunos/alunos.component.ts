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

  colunas: any[] = ["Id", "Nome", "CPF", "Idade"];

  alunos: Alunos[] = [
    {id: 1, nome: 'Yuri', cpf: '000.000.000-01', idade: 22},
    {id: 2, nome: 'Laryssa', cpf: '000.000.000-02', idade: 20}
  ]
}

export class Alunos{
  id: number;
  nome: string;
  cpf: String;
  idade: number;
}
