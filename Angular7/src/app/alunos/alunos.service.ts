import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Aluno } from '../models/Aluno';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AlunosService {

  private readonly API = 'http://localhost:3000/cursos'

  constructor(private http: HttpClient) { }

  list(){
    return this.http.get<Aluno[]>(this.API)
    .pipe(
      tap(console.log)
    );
  }
}
