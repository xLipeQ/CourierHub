import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit{
  users : string = "";

  ngOnInit(): void {
    this.users = (Math.random() * 100000 + 50000).toFixed();
  }

}
