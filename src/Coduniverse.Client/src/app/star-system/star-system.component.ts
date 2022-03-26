import { Component, Injectable, OnInit } from '@angular/core';
import { StarSystem } from '../models/star-system';
import { StarSystemService } from '../services/starsystem.service';

@Component({
  selector: 'app-star-system',
  templateUrl: './star-system.component.html',
  styleUrls: ['./star-system.component.scss']
})

@Injectable()
export class StarSystemComponent implements OnInit {

  starSystem!: StarSystem;
  constructor(
    private starSystemService: StarSystemService,
  ) { }
  ngOnInit() {
    this.starSystemService.getStarSystems().subscribe((data: any) => this.starSystem = data[0]);
  }

  removeObject(spaceObjectId: string) {
    let spaceObjectIndex = this.starSystem.spaceObjects.findIndex(x => x.id == spaceObjectId);
    if (spaceObjectIndex > -1) {
      this.starSystem.spaceObjects.splice(spaceObjectIndex, 1);
    }
  }

}
