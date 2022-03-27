import { Component, OnInit } from '@angular/core';
import { StarSystem } from '../models/star-system';
import { StarSystemService } from '../services/starsystem.service';

@Component({
  selector: 'app-universe',
  templateUrl: './universe.component.html',
  styleUrls: ['./universe.component.scss']
})
export class UniverseComponent implements OnInit {

  starSystems: StarSystem[] = [];

  constructor(private starSystemService: StarSystemService) { }

  ngOnInit(): void {
    this.starSystemService.getStarSystems().subscribe((data: any) => {
      this.starSystems = data;
    })
  }

  deleteStarSystem(id: string) {
    this.starSystemService.delete(id).subscribe((data: any) => {
      let starSystemIndex = this.starSystems.findIndex(x => x.id == id);
      if (starSystemIndex > -1) {
        this.starSystems.splice(starSystemIndex, 1);
      }
    });
  }
}
