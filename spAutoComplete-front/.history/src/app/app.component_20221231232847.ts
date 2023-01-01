import { Component } from "@angular/core";
import { ma } from "./services/gets.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"],
})
export class AppComponent {
  searchForAutoComplete = (type: string, event: any) => {};
}
