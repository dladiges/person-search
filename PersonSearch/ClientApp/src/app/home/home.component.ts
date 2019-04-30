import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Search } from '../model/search';
import { Person } from '../model/person';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public people: Person[];

  constructor(private http: HttpClient) { }

  public searchPeople(search: Search) {
    console.log(JSON.stringify(search));

    const headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });
    this.http.post(environment.personapi + 'search', JSON.stringify(search), { headers: headerOptions })
      .subscribe(result => {
        this.people = result as Person[]
        console.log(this.people);
      }, error => console.error(error));
  }
}
