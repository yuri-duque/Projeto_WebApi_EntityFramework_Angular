import { Component, OnInit, SimpleChanges, Directive } from '@angular/core';
import { Aluno } from 'src/app/models/Aluno';
import { AlunosService } from 'src/app/service/alunos.service';
import { Router } from '@angular/router';
import { Validators, FormControl, ValidatorFn, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-alunos-form',
  templateUrl: './alunos-form.component.html',
  styleUrls: ['./alunos-form.component.css']
})
export class AlunosFormComponent implements OnInit {

  constructor(private alunosService: AlunosService, private router: Router) { }

  aluno: Aluno = new Aluno();
  cadastrando: boolean;

  textoBotaoSubmit: string;
  tituloFormulario: string;
  url: string;

  ngOnInit() {
    this.CadastrandoOuAlterando();
  }

  cpfValidator(c: AbstractControl){
    if (!c.value) return null;
    return new RegExp('^((\d{3}).(\d{3}).(\d{3})-(\d{2}))*$').test(c.value) ? null : {
      validateNumber: {
        //valid: false
        valid: true //alterado pois a validação não está funcionando
      }
    };
  }

  onSubmit(form){
    console.log(form);

    if(this.cadastrando)
      this.alunosService.salvarAluno(this.aluno).subscribe(
        data => this.router.navigate(["/alunos"]),
        data => alert("Aluno Cadastrado!")
        );
    else
      this.alunosService.alterarAluno(this.aluno.alunoId, this.aluno).subscribe(
          data => this.router.navigate(["/alunos"]),
          data => alert("Aluno Cadastrado!")
        );
  }

  //Metodo usado para alterar dinamicamente o Titulo e o text do botão no formulário
  CadastrandoOuAlterando(){
    
    this.url = window.location.href;

    if(this.url.search("alterar") != -1){
      this.tituloFormulario = "Alterando aluno";
      this.textoBotaoSubmit = "Alterar";

      this.cadastrando = false;
      this.GetAlunoById(this.url);
    }
    else if(this.url.search("cadastro") != -1){
      this.tituloFormulario = "Cadastrando aluno";
      this.textoBotaoSubmit = "Cadastrar";

      this.cadastrando = true;
    }
  }

  GetAlunoById(url: string){

    let parameters = url.split("/")
    this.aluno.alunoId = Number(parameters[parameters.length - 1]);

    this.alunosService.buscarPorId(this.aluno.alunoId).subscribe(
      aluno => this.aluno = aluno
    )
  }
}
