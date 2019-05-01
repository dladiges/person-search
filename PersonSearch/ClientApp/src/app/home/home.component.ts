import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { isNullOrUndefined, isNumber } from 'util';
import { Search } from '../model/search';
import { Person } from '../model/person';
import { Interest } from '../model/interest';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  public people: Person[];
  public loading : boolean;

  constructor(private http: HttpClient) {
    this.loading = false;
  }

  public searchPeople(search: Search) {
    // console.log(JSON.stringify(search));

    this.loading = true;

    // Enforce a minimum delay of zero seconds
    if (isNullOrUndefined(search.delayInSeconds) || search.delayInSeconds <= 0 )
      search.delayInSeconds = 0;

    // Enforce a minimum max result count of 1
    if (isNullOrUndefined(search.maxResultCount) || search.maxResultCount < 1)
      search.maxResultCount = 5;

    const headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });
    
    this.http.post(environment.personapi + 'search', JSON.stringify(search), { headers: headerOptions })
      .subscribe(result => {
        this.people = result as Person[];
        this.loading = false;
        // console.log(this.people);
      }, error => {
        console.error(error);
        this.loading = false;
      }
      );
  }
}
