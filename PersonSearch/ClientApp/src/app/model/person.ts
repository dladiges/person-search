import { Interest } from "./interest";

export interface Person {
  address1: string;
  address2: string;
  birthDate: Date;
  city: string;
  country: string;
  familyName: string;
  givenName: string;
  interests: Interest[];
  middleName: string;
  personId: number;
  photoFileName: string;
  postalCode: string;
  state: string;
}
