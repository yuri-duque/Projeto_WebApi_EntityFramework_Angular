import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from '@angular/core';

import { AppComponent } from './app.component';
import { AlunosComponent } from './alunos/alunos.component';

const routes: Routes = [
  {path: 'alunos', component: AlunosComponent}
];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes);
