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

  getAll(){
    return this.http.get<Aluno[]>(this.url)
    .pipe(
      tap(console.log)
    );
  }

  //Executar para ver a difereça do metodo acima
  // list(){
  //   let teste = this.http.get<Aluno[]>(this.url)
  //   console.log(teste);
  // }

  getAlunoById(id: number){
    return this.http.get<Aluno>(this.url +'/'+ id) //GET api/aluno/1 ----- Uma das formas de concatenas uma string com variavel
    .pipe(
      tap(console.log)
    );
  }

  postAluno(aluno: Aluno): Observable<Aluno>{
    return this.http.post<Aluno>(this.url, aluno, httpOptions) //POST api/aluno
    .pipe(
      tap(console.log)
    );
  }

  putAluno (aluno: Aluno): Observable<Aluno> {
    return this.http.put<Aluno>(this.url, aluno, httpOptions) //PUT api/aluno/1
      .pipe(
        tap(console.log)
      );
  }

  deleteHero (id: number): Observable<{}> {
    const url = `${this.url}/${id}`; // DELETE api/aluno/1 ----- Outra forma de concatenar uma string com variavel (igual a $"...{id}" no C#)
    return this.http.delete(url, httpOptions)
      .pipe(
        tap(console.log)
      );
  }
}


