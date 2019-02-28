import { Router } from '@angular/router';
import { Component, OnInit, Input } from '@angular/core';
import { NgxSmartModalService } from 'ngx-smart-modal';
import { AlunosService } from 'src/app/service/alunos.service';
import { Aluno } from 'src/app/models/Aluno';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css'],
})
export class AlunosComponent implements OnInit {  
  alunos: Aluno[];

  aluno: Aluno;

  testeNome1: string;
  testeCont: string;

  //Usado para definir os nomes das colunas da tabela de listagem
  colunas: any[] = ["Id", "Nome", "CPF", "Idade"];

  constructor(
    public ngxSmartModalService: NgxSmartModalService,
    private alunosService: AlunosService,
    private router: Router
    ) {}

  ngOnInit() {  
    this.Listagem();
  }

  //Metodo usado para abir o modal de detalhes
  Open(id: number) {
    //alert(id);

    this.alunosService.buscarPorId(id).subscribe(aluno => this.aluno = aluno);

    this.ngxSmartModalService.getModal('myModal').open();
  }

  RemoverAluno(id: number){
    this.alunosService.removerAluno(id).subscribe();
    //location.reload() //Recarrega a pagina
    this.Listagem();
  }

  //Listagem de alunos buscando na api
  Listagem(){
    //subscribe - Executa q query em async
    this.alunosService.buscarTodos().subscribe(
      alunos => this.alunos = alunos
    )
    //Caso de algum erro será tratado aqui
    //error(

    //),
    //Metodo Complete - caso seja necessário buscar os alunos de uma sala especifica ( buca-se a sala na listame, depois realiza a busca dos alunos dentro do metodo abaixo)
    //() => {
      
    //}
  }
}
