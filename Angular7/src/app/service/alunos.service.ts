import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Aluno } from '../models/Aluno';
import { tap, catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})

export class AlunosService {

  //Url da API
  private readonly url = 'http://localhost:61709/api/aluno'

  constructor(private http: HttpClient) { }

  buscarTodos() : Observable<Aluno[]>{
    return this.http.get<Aluno[]>(this.url);
  }

  buscarPorId(id: number) : Observable<Aluno>{
    return this.http.get<Aluno>(this.url +'/'+ id); //GET api/aluno/1 ----- Uma das formas de concatenas uma string com variavel
  }

  salvarAluno(aluno: Aluno){
    return this.http.post(this.url, aluno, httpOptions); //POST api/aluno
  }

  alterarAluno (aluno: Aluno){
    return this.http.put<Aluno>(this.url, aluno, httpOptions); //PUT api/aluno/1
  }

  deletarAluno (id: number) {
    const url = `${this.url}/${id}`; // DELETE api/aluno/1 ----- Outra forma de concatenar uma string com variavel (igual a $"...{id}" no C#)
    return this.http.delete(url, httpOptions);
  }
}


