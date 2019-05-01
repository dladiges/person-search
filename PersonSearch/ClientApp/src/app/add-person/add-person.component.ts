import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Person } from '../model/person';
import { Interest } from '../model/interest';

@Component({
  selector: 'app-add-person',
  templateUrl: './add-person.component.html',
  styleUrls: ['./add-person.component.css'],
})
export class AddPersonComponent {
  public 

  constructor(private http: HttpClient) { }

  public addPerson(person: Person) {
    console.log(JSON.stringify(person));

    const headerOptions = new HttpHeaders({ 'Content-Type': 'application/json' });
    this.http.post(environment.personapi + 'person', JSON.stringify(person), { headers: headerOptions })
      .subscribe(result => {
        console.log(result);
      }, error => console.error(error));
  }
}
