import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html'
})

export class SearchComponent {
  public success: boolean;

  constructor(private http: HttpClient) { }

  public search() {
    this.http.get(environment.personapi + 'search')
      .subscribe(result => {
        "test"
      }, error => console.error(error));
  }
}
