import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-seed-data',
  templateUrl: './seed-data.component.html'
})
export class SeedDataComponent {
  public success: boolean;

  constructor(private http: HttpClient) { }

  public seedData() {
    this.http.post(environment.personapi + 'data/seed', "Seed Test Data")
      .subscribe(result => {
      this.success = true;
    }, error => console.error(error));
  }
}
