import { Component } from "@angular/core";
import {PostsService } from "./services/gets.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  searchForAutoComplete = (type: string, event: any) => {};
}