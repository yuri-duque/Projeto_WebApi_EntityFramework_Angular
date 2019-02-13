import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AlunosDetalhesComponent } from './alunos-detalhes.component';

describe('AlunosDetalhesComponent', () => {
  let component: AlunosDetalhesComponent;
  let fixture: ComponentFixture<AlunosDetalhesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlunosDetalhesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AlunosDetalhesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
