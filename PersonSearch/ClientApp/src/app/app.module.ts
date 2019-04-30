import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { AddPersonComponent } from './add-person/add-person.component';
import { SearchResultComponent } from './search-result/search-result.component';
import { SeedDataComponent } from './seed-data/seed-data.component';
import { ResetDataComponent } from './reset-data/reset-data.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    AddPersonComponent,
    SearchResultComponent,
    SeedDataComponent,
    ResetDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'add-person', component: AddPersonComponent },
      { path: 'search-result', component: SearchResultComponent },
      { path: 'seed-data', component: SeedDataComponent },
      { path: 'reset-data', component: ResetDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
