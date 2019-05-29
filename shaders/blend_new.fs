#include std_head_fs.inc

varying vec2 texcoordoutf;
varying vec2 texcoordoutb;

void main(void) {
  vec4 texf = texture2D(tex0, texcoordoutf);
  vec4 texb = texture2D(tex1, texcoordoutb);

  // blending
  float a = unif[14][2];

  // simple fade //////////////////////////////////////////////////////
  gl_FragColor = mix(texb, texf, a);

  // burn /////////////////////////////////////////////////////////////
  //float y = 1.0 - smoothstep(a, a * 1.2, length(texf.rgb) * 0.577 + 0.01);
  //gl_FragColor = mix(texb, texf * y, step(1.0, y));

  // bump /////////////////////////////////////////////////////////////
  //vec4 light = vec4(0.577, 0.577, 0.577, 1.0);
  //float ffact = dot(light, texf);
  //gl_FragColor = mix(texb * (1.0 + a * (ffact - 1.0)), texf, clamp(2.0 * a - 1.0, 0.0, 1.0));
}
