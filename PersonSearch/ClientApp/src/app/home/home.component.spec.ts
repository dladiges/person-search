import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { HomeComponent } from "./home.component";
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Search } from '../model/search';
import { Person } from '../model/person';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [HomeComponent],
      imports: [FormsModule, HttpClientModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('#loading should be false on load', () => {
    expect(component.loading === false);
  });
  
  it('Search Results (people) should be empty on component load', () => {
    expect(component.people === null);
  });
  
  it('#searchPeople("test", 5, 0) should not toggle #loading', () => {
    let search: Search = { searchText: "test", delayInSeconds: 0, maxResultCount : 10 };

    component.searchPeople(search);
    expect(component.loading === false);
  });
});
