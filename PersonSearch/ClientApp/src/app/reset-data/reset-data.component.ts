import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-reset-data',
  templateUrl: './reset-data.component.html'
})

export class ResetDataComponent {
  public success: boolean = false;
  public failure: boolean = false;

  constructor(private http: HttpClient) { }

  public resetData() {
    this.http.post(environment.personapi + 'data/reset', "Reset Database")
      .subscribe(result => {
        this.success = true;
      }, error => {
          console.error(error);
          this.failure = true;
      } );
  }
}
