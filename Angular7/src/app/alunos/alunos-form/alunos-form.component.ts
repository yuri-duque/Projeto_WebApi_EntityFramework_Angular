import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos-form',
  templateUrl: './alunos-form.component.html',
  styleUrls: ['./alunos-form.component.css']
})
export class AlunosFormComponent implements OnInit {

  constructor() { }

  textoBotaoSubmit: string;
  tituloFormulario: string;

  url: string 

  ngOnInit() {
    this.AlteraValorTituloEbotao();
  }

  AlteraValorTituloEbotao(){

    this.url = window.location.href;

    if(this.url.search("alterar") != -1){
      this.tituloFormulario = "Alterando aluno";
      this.textoBotaoSubmit = "Alterar";
    }
    else if(this.url.search("cadastro") != -1){
      this.tituloFormulario = "Cadastrando aluno";
      this.textoBotaoSubmit = "Cadastrar";
    }
  }
}
