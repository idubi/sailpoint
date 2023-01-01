import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import {map} from 'rxjs';
import { query } from "express";

@Injectable({
  providedIn: "root",
})
export class PostsService {
  constructor(private http: HttpClient) {
    
  }

  matchAutocomplete = (type: string, quesy: string) => {
    return this.http.get<
      `/api/AutoComplete/get_match?fileName=${type}&query=${query}`,
      options:{
        headers: new HttpHeaders({ "content-type": "application/json" }),
      }
    >;
  };
}
