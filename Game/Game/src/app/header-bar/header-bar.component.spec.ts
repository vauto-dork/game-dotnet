import { TestBed, async } from '@angular/core/testing';

import { HeaderBarComponent } from './header-bar.component';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        HeaderBarComponent
      ],
    }).compileComponents();
  }));

  it('should create the headerbar', async(() => {
    const fixture = TestBed.createComponent(HeaderBarComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));

  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(HeaderBarComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Yeh Is Testing 123');
  }));
});
